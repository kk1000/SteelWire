﻿using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;

namespace SteelWire.AppCode
{
    /// <summary>
    /// 时钟
    /// </summary>
    public class TimeMeter : DependencyObject
    {
        private delegate void SetTimePropertyDelegate(DateTime now);
        private readonly object _timeLocker = new object();
        public event EventHandler CurrentTimeChangedHandler;
        public static readonly DependencyProperty CurrentTimeProperty;
        /// <summary>
        /// 单例
        /// </summary>
        private static readonly TimeMeter _instance;
        private Timer _timer;

        /// <summary>
        /// 静态构造
        /// </summary>
        static TimeMeter()
        {
            DateTime now = DateTime.Now;
            CurrentTimeProperty = DependencyProperty.Register("CurrentTime", typeof(DateTime), typeof(TimeMeter),
                new FrameworkPropertyMetadata
                {
                    DefaultValue = now,
                    PropertyChangedCallback = OnCurrentTimePropertyChanged
                });
            _instance = new TimeMeter
            {
                CurrentTime = now,
            };
        }

        /// <summary>
        /// 单例
        /// </summary>
        public static TimeMeter OnceInstance
        {
            get { return _instance; }
        }

        /// <summary>
        /// 依赖项修改触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OnCurrentTimePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            TimeMeter timeMeter = (TimeMeter)sender;
            timeMeter.OnCurrentTimeChanged(EventArgs.Empty);
        }

        /// <summary>
        /// 当前时间
        /// </summary>
        public DateTime CurrentTime
        {
            get { return (DateTime)this.GetValue(CurrentTimeProperty); }
            set
            {
                lock (this._timeLocker)
                {
                    SetValue(CurrentTimeProperty, value);
                }
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        private TimeMeter()
        {
            this._timer = new Timer(SetTime, null, 0, 30000);
        }

        /// <summary>
        /// 当前时间修改触发事件
        /// </summary>
        /// <param name="e"></param>
        private void OnCurrentTimeChanged(EventArgs e)
        {
            EventHandler handler = CurrentTimeChangedHandler;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }

        /// <summary>
        /// 定时刷新时间（异步）
        /// </summary>
        /// <param name="state"></param>
        private void SetTime(object state)
        {
            SetTimePropertyDelegate method = SetTime;
            this.Dispatcher.BeginInvoke(method, DispatcherPriority.Send, DateTime.Now);
        }

        /// <summary>
        /// 定时刷新时间
        /// </summary>
        /// <param name="now"></param>
        private void SetTime(DateTime now)
        {
            SetValue(CurrentTimeProperty, now);
        }
    }

    /// <summary>
    /// 计时器文本转换器
    /// </summary>
    public class TimeMeterTextConverter : IValueConverter
    {
        public object Convert(object value, Type typeTarget, object param, CultureInfo culture)
        {
            string format = param as string;
            if (!string.IsNullOrWhiteSpace(format))
            {
                return string.Format(format, value);
            }
            if (!(value is DateTime))
            {
                return string.Format("{0}", value);
            }
            DateTime now = (DateTime)value;
            return now.GetDateTimeFormats('D')[1];
        }

        public object ConvertBack(object value, Type typeTarget, object param, CultureInfo culture)
        {
            return DateTime.Now;
        }
    }
}

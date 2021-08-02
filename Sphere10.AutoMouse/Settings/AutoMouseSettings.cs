using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using Sphere10.Framework;
using Sphere10.Framework.Application;
using Tools;

namespace Sphere10.AutoMouse {

    [Obfuscation(Exclude = true)]
	public class AutoMouseSettings : SettingsObject {

		[DefaultValue(true)]
		public bool ScreenMouseKeepAliveOnManualActivation { get; set; }

		[DefaultValue(AutoMouseBehavior.AutoActivateScreenMouse)]
		public AutoMouseBehavior MouseStoppedBehavior { get; set; }

		[DefaultValue(true)]
		public bool ShowExpandingRings { get; set; }

		[DefaultValue(false)]
		public bool KeyboardArrowsMoveScreenMouse { get; set; }

		[DefaultValue(true)]
		public bool MakeClickSound { get; set; }

		[DefaultValue(true)]
		public bool AutoStartProgram { get; set; }

		[DefaultValue(Key.LControlKey)]
		public Key ScreenMouseActivationKey { get; set; }

		[DefaultValue(1000)]
		public int ScreenMouseTimeoutMS { get; set; }

		public TimeSpan ScreenMouseTimeout {
			get { return TimeSpan.FromMilliseconds(ScreenMouseTimeoutMS); }
			set { ScreenMouseTimeoutMS = (int)value.TotalMilliseconds; }
		}

		[DefaultValue(Key.D1)]
		public Key LeftButtonKey { get; set; }

		[DefaultValue(Key.D2)]
		public Key MiddleButtonKey { get; set; }

		[DefaultValue(Key.D3)]
		public Key RightButtonKey { get; set; }

		[DefaultValue(MouseButton.Left)]
		public MouseButton AutoClickButton { get; set; }

		[DefaultValue(MouseClickType.Single)]
		public MouseClickType AutoClickType { get; set; }

		[DefaultValue(true)]
		public bool AutoClickShowScreenMouse { get; set; }

		[DefaultValue(50)]
		public int ClickFreeZoneRadius { get; set; }

		[DefaultValue(30)]
		public int MultipleClickIntervalMS { get; set; }

		public TimeSpan MultipleClickInterval {
			get { return TimeSpan.FromMilliseconds(MultipleClickIntervalMS); }
			set { MultipleClickIntervalMS = (int)value.TotalMilliseconds; }
		}

		[DefaultValue(10)]
		public int MouseUpIntervalMS { get; set; }

		public TimeSpan MouseUpInterval {
			get { return TimeSpan.FromMilliseconds(MouseUpIntervalMS); }
			set { MouseUpIntervalMS = (int) value.TotalMilliseconds; }
		}

		[DefaultValue(30)]
		public int ExpandingRingRadius { get; set; }

		[DefaultValue(5)]
		public int ExpandingRingThickness { get; set; }

		[DefaultValue(50)]
		public int ExpandingRingSpeedPixelsPerSecond { get; set; }

		[DefaultValue("255:0:0:255")]
		public string ExpandingRingColorARGB { get; set; }

		public Color ExpandingRingColor {
			get { return Drawing.ConvertStringToColor(ExpandingRingColorARGB); }
			set { ExpandingRingColorARGB = value.ToARGBString(); }
		}


		[DefaultValue("255:255:0:0")]
		public string ExpandingRingColor2ARGB { get; set; }
		
		public Color ExpandingRingColor2 {
			get { return Drawing.ConvertStringToColor(ExpandingRingColor2ARGB); }
			set { ExpandingRingColor2ARGB = value.ToARGBString(); }
		}

		[DefaultValue(0.25f)]
		public float ScreenMouseIdleAlpha { get; set; }

		public int ScreenMouseIdleAlphaPercentage {
			get {
				return (int)Math.Round(ScreenMouseIdleAlpha*100.0d);
			}
			set { 
				ScreenMouseIdleAlpha = value/100.0f;
			}
		}


		[DefaultValue(0.75f)]
		public float ScreenMouseActiveAlpha { get; set; }

		public int ScreenMouseActiveAlphaPercentage {
			get {
				return (int)Math.Round(ScreenMouseActiveAlpha * 100.0d);
			}
			set {
				ScreenMouseActiveAlpha = value / 100.0f;
			}
		}


		[DefaultValue(2000)]
		public int ScreenMouseFadeDurationMS { get; set; }

		public TimeSpan ScreenMouseFadeDuration {
			get { return TimeSpan.FromMilliseconds(ScreenMouseFadeDurationMS); }
			set { ScreenMouseFadeDurationMS = (int)value.TotalMilliseconds; }
		}

        [Obfuscation(Exclude = true)]
        public enum AutoMouseBehavior {
            AutoActivateScreenMouse,
            AutoClickOnMouseStop,
            ManuallyActivateScreenMouse
        }

    }

}

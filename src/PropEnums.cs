using System;
using VL.Core.CompilerServices;
using VL.Lib.Collections;

namespace DigiCamControl
{
    public class ShutterSpeedDefinition : ManualDynamicEnumDefinitionBase<ShutterSpeedDefinition>
    {
        public static ShutterSpeedDefinition Instance => ManualDynamicEnumDefinitionBase<ShutterSpeedDefinition>.Instance;

        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class ShutterSpeed : DynamicEnumBase<ShutterSpeed, ShutterSpeedDefinition>
    {
        public ShutterSpeed(string value) : base(value)
        {
        }

        [CreateDefault]
        public static ShutterSpeed CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }


    public class ApertureDefinition : ManualDynamicEnumDefinitionBase<ApertureDefinition>
    {
        public static ApertureDefinition Instance => ManualDynamicEnumDefinitionBase<ApertureDefinition>.Instance;
        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class Aperture : DynamicEnumBase<Aperture, ApertureDefinition>
    {
        public Aperture(string value) : base(value)
        {
        }

        [CreateDefault]
        public static Aperture CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }


    public class ISONumberDefinition : ManualDynamicEnumDefinitionBase<ISONumberDefinition>
    {
        public static ISONumberDefinition Instance => ManualDynamicEnumDefinitionBase<ISONumberDefinition>.Instance;
        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class ISONumber : DynamicEnumBase<ISONumber, ISONumberDefinition>
    {
        public ISONumber(string value) : base(value)
        {
        }

        [CreateDefault]
        public static ISONumber CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }



    public class ExposureMeteringModeDefinition : ManualDynamicEnumDefinitionBase<ExposureMeteringModeDefinition>
    {
        public static ExposureMeteringModeDefinition Instance => ManualDynamicEnumDefinitionBase<ExposureMeteringModeDefinition>.Instance;
        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class ExposureMeteringMode : DynamicEnumBase<ExposureMeteringMode, ExposureMeteringModeDefinition>
    {
        public ExposureMeteringMode(string value) : base(value)
        {
        }

        [CreateDefault]
        public static ExposureMeteringMode CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }

    public class ExposureCompensationDefinition : ManualDynamicEnumDefinitionBase<ExposureCompensationDefinition>
    {
    public static ExposureCompensationDefinition Instance => ManualDynamicEnumDefinitionBase<ExposureCompensationDefinition>.Instance;
    }

    [Serializable]
    public class ExposureCompensation : DynamicEnumBase<ExposureCompensation, ExposureCompensationDefinition>
    {
        public ExposureCompensation(string value) : base(value)
        {
        }

        [CreateDefault]
        public static ExposureCompensation CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }

    public class WhiteBalanceDefinition : ManualDynamicEnumDefinitionBase<WhiteBalanceDefinition>
    {
        public static WhiteBalanceDefinition Instance => ManualDynamicEnumDefinitionBase<WhiteBalanceDefinition>.Instance;
        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class WhiteBalance : DynamicEnumBase<WhiteBalance, WhiteBalanceDefinition>
    {
        public WhiteBalance(string value) : base(value)
        {
        }

        [CreateDefault]
        public static WhiteBalance CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }

    public class FocusModeDefinition : ManualDynamicEnumDefinitionBase<FocusModeDefinition>
    {
        public static FocusModeDefinition Instance => ManualDynamicEnumDefinitionBase<FocusModeDefinition>.Instance;
        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class FocusMode : DynamicEnumBase<FocusMode, FocusModeDefinition>
    {
        public FocusMode(string value) : base(value)
        {
        }

        [CreateDefault]
        public static FocusMode CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }

    public class CompressionSettingDefinition : ManualDynamicEnumDefinitionBase<CompressionSettingDefinition>
    {
        public static CompressionSettingDefinition Instance => ManualDynamicEnumDefinitionBase<CompressionSettingDefinition>.Instance;
        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class CompressionSetting : DynamicEnumBase<CompressionSetting, CompressionSettingDefinition>
    {
        public CompressionSetting(string value) : base(value)
        {
        }

        [CreateDefault]
        public static CompressionSetting CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }

    public class AdvancedPropertiesModeDefinition : ManualDynamicEnumDefinitionBase<AdvancedPropertiesModeDefinition>
    {
        public static AdvancedPropertiesModeDefinition Instance => ManualDynamicEnumDefinitionBase<AdvancedPropertiesModeDefinition>.Instance;
        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class AdvancedPropertiesMode : DynamicEnumBase<AdvancedPropertiesMode, AdvancedPropertiesModeDefinition>
    {
        public AdvancedPropertiesMode(string value) : base(value)
        {
        }

        [CreateDefault]
        public static AdvancedPropertiesMode CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }

    public class AdvancedPropertiesValueDefinition : ManualDynamicEnumDefinitionBase<AdvancedPropertiesValueDefinition>
    {
        public static AdvancedPropertiesValueDefinition Instance => ManualDynamicEnumDefinitionBase<AdvancedPropertiesValueDefinition>.Instance;
        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class AdvancedPropertiesValue : DynamicEnumBase<AdvancedPropertiesValue, AdvancedPropertiesValueDefinition>
    {
        public AdvancedPropertiesValue(string value) : base(value)
        {
        }

        [CreateDefault]
        public static AdvancedPropertiesValue CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }

    public class CameraDeviceDefinition : ManualDynamicEnumDefinitionBase<CameraDeviceDefinition>
    {
        public static CameraDeviceDefinition Instance => ManualDynamicEnumDefinitionBase<CameraDeviceDefinition>.Instance;
        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class CameraDevice : DynamicEnumBase<CameraDevice, CameraDeviceDefinition>
    {
        public CameraDevice(string value) : base(value)
        {
        }

        [CreateDefault]
        public static CameraDevice CreateDefault()
        {
            //use method of base class if nothing special required
            return CreateDefaultBase();
        }
    }
}
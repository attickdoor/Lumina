using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyExpedition", columnHash: 0x4695a239 )]
    public class GcArmyExpedition : IExcelRow
    {
        public struct UnkStruct10Struct
        {
            public int RewardItem;
        }
        public struct UnkStruct16Struct
        {
            public byte RewardQuantity;
        }
        public struct UnkStruct22Struct
        {
            public ushort RequiredPhysical;
        }
        public struct UnkStruct28Struct
        {
            public byte PercentPhysicalMet;
        }
        public struct UnkStruct34Struct
        {
            public ushort RequiredMental;
        }
        public struct UnkStruct40Struct
        {
            public byte PercentMentalMet;
        }
        public struct UnkStruct46Struct
        {
            public ushort RequiredTactical;
        }
        public struct UnkStruct52Struct
        {
            public byte PercentTacticalMet;
        }
        public struct UnkStruct58Struct
        {
            public byte PercentAllMet;
        }
        
        public byte RequiredFlag;
        public byte UnlockFlag;
        public byte RequiredLevel;
        public ushort RequiredSeals;
        public uint RewardExperience;
        public byte PercentBase;
        public byte Unknown6;
        public LazyRow< GcArmyExpeditionType > GcArmyExpeditionType;
        public string Name;
        public string Description;
        public UnkStruct10Struct[] UnkStruct10;
        public UnkStruct16Struct[] UnkStruct16;
        public UnkStruct22Struct[] UnkStruct22;
        public UnkStruct28Struct[] UnkStruct28;
        public UnkStruct34Struct[] UnkStruct34;
        public UnkStruct40Struct[] UnkStruct40;
        public UnkStruct46Struct[] UnkStruct46;
        public UnkStruct52Struct[] UnkStruct52;
        public UnkStruct58Struct[] UnkStruct58;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            RequiredFlag = parser.ReadColumn< byte >( 0 );
            UnlockFlag = parser.ReadColumn< byte >( 1 );
            RequiredLevel = parser.ReadColumn< byte >( 2 );
            RequiredSeals = parser.ReadColumn< ushort >( 3 );
            RewardExperience = parser.ReadColumn< uint >( 4 );
            PercentBase = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            GcArmyExpeditionType = new LazyRow< GcArmyExpeditionType >( lumina, parser.ReadColumn< byte >( 7 ) );
            Name = parser.ReadColumn< string >( 8 );
            Description = parser.ReadColumn< string >( 9 );
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct10[ i ] = new UnkStruct10Struct();
                UnkStruct10[ i ].RewardItem = parser.ReadColumn< int >( 10 + ( i * 6 + 0 ) );
            }
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct16[ i ] = new UnkStruct16Struct();
                UnkStruct16[ i ].RewardQuantity = parser.ReadColumn< byte >( 16 + ( i * 6 + 0 ) );
            }
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct22[ i ] = new UnkStruct22Struct();
                UnkStruct22[ i ].RequiredPhysical = parser.ReadColumn< ushort >( 22 + ( i * 6 + 0 ) );
            }
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct28[ i ] = new UnkStruct28Struct();
                UnkStruct28[ i ].PercentPhysicalMet = parser.ReadColumn< byte >( 28 + ( i * 6 + 0 ) );
            }
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct34[ i ] = new UnkStruct34Struct();
                UnkStruct34[ i ].RequiredMental = parser.ReadColumn< ushort >( 34 + ( i * 6 + 0 ) );
            }
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct40[ i ] = new UnkStruct40Struct();
                UnkStruct40[ i ].PercentMentalMet = parser.ReadColumn< byte >( 40 + ( i * 6 + 0 ) );
            }
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct46[ i ] = new UnkStruct46Struct();
                UnkStruct46[ i ].RequiredTactical = parser.ReadColumn< ushort >( 46 + ( i * 6 + 0 ) );
            }
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct52[ i ] = new UnkStruct52Struct();
                UnkStruct52[ i ].PercentTacticalMet = parser.ReadColumn< byte >( 52 + ( i * 6 + 0 ) );
            }
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct58[ i ] = new UnkStruct58Struct();
                UnkStruct58[ i ].PercentAllMet = parser.ReadColumn< byte >( 58 + ( i * 6 + 0 ) );
            }
        }
    }
}
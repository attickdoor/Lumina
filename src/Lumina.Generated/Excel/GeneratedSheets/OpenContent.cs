using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OpenContent", columnHash: 0xbdff33b7 )]
    public class OpenContent : IExcelRow
    {
        
        public LazyRow< ContentFinderCondition >[] Content;
        public LazyRow< OpenContentCandidateName >[] CandidateName;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            for( var i = 0; i < 16; i++ )
                Content[ i ] = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< ushort >( 0 + i ) );
            for( var i = 0; i < 16; i++ )
                CandidateName[ i ] = new LazyRow< OpenContentCandidateName >( lumina, parser.ReadColumn< uint >( 16 + i ) );
        }
    }
}
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using SongManager.Data;

namespace SongManager
{
    public class Helper
    {   
        public static string ConString = "";
        public const string ValidNumberReqular = @"^([0-9]{2,3})$";
        public const string ValidNumber = @"^\d+$";
        public const string MessageInvalidAlbumNum = "Invalid Album number.\n Allow number only.";
        public const string MessageNotEmpyAlumNum = "Alum num is require.";
        public const string MessageNotEmptyProduction = "Production is require.";
        public const string MessageNotEmptySongTypeName = "SongType name is require.";
        public const string MessageNotEmptySingerName = "Singer name is require.";
        public const string MessageNotEmptyCadenceName = "Cadence name is require.";
        public const string MessageNotEmptyTitle = "Title is require.";
        public const string MessageNotPath = "Path is require.";
        public const string FilterFileType = "(*.DAT)|*.DAT|(*.MP3)|*.MP3|(*.MP4)|*.MP4|(*.3GP)|*.3GP|(*.MOV)|*.MOV|(*.WMA)|*.WMA|(*.FLV)|*.FLV";
        public const string SearchTitle = "ស្វែងរកចំណងជើងបទចំរៀង";
        public const string SearchSinger = "ស្វែងរកអ្នកចំរៀង";
        public const string SearchProduction = "ស្វែងរកផលិតកម្ម";
        public const string SearchCadence = "ស្វែងរកចង្វាក់";
        public const string SearchFileType = "ស្វែងរកប្រភេទឯកសារ";
        public const string HeaderId = "លេខរៀង";
        public const string HeaderTitle = "ចំណងជើងបទចំរៀង";
        public const string HeaderSinger = "អ្នកចំរៀង";
        public const string HeaderProduction = "ផលិតកម្ម";
        public const string HeaderSongType = "ប្រភេទចំរៀង";
        public const string HeaderAlbum = "លេខអ៊ាល់ប៊ុម";
        public const string HeaderCadence = "ចង្វាក់​";
        public const string HeaderFileType = "ប្រភេទឯកសារ";

        private static InputLanguage _inputEnglish;
        private static InputLanguage _inputKhmer;
        public static InputLanguage Khmer()
        {
            if (_inputKhmer == null)
            {
                for (int i = 0; i < InputLanguage.InstalledInputLanguages.Count; i++)
                {
                    var layoutName = InputLanguage.InstalledInputLanguages[i].LayoutName;
                    if (layoutName != null && (layoutName.ToLower().Contains("khmer")
                                                                                        || layoutName.ToLower().Contains("cambodian")))
                    {
                        _inputKhmer = InputLanguage.InstalledInputLanguages[i];
                    }
                }
            }
            return _inputKhmer;
        }

        public static InputLanguage English()
        {
            if (_inputEnglish == null)
            {
                for (int i = 0; i < InputLanguage.InstalledInputLanguages.Count; i++)
                {
                    var layoutName = InputLanguage.InstalledInputLanguages[i].LayoutName;
                    if (layoutName != null && (layoutName.ToLower().Contains("us")
                                                                                        || layoutName.ToLower().Contains("united states")))
                    {
                        _inputEnglish = InputLanguage.InstalledInputLanguages[i];
                    }
                }
            }
            return _inputEnglish;
        }
    }
}

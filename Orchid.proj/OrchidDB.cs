using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Orchid.proj
{
    public class OrchidDB
    {
        private const string dir = @"C:\C# 2010\Files\";
        private const string path = dir + "Orchid.dat";

        public static Orchid GetOrchid()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            BinaryReader binaryIn =
                new BinaryReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));


            Orchid orchid = new Orchid();
            while (binaryIn.PeekChar() != -1)
            {
                orchid.NextWatering = binaryIn.ReadString();
                orchid.NextFertilizing = binaryIn.ReadString();
                orchid.CareInfo = binaryIn.ReadString();
            }

            binaryIn.Close();

            return orchid;

        }

        public static void SaveOrchid(Orchid orchid)
        {
            BinaryWriter binaryOut = 
                new BinaryWriter (
                new FileStream(path, FileMode.Create,FileAccess.Write));

            {
                binaryOut.Write(orchid.NextWatering);
                orchid.GetNextWatering(orchid.NextWatering);

                binaryOut.Write(orchid.NextFertilizing);
                orchid.GetNextFertilizing(orchid.NextFertilizing);

                binaryOut.Write(orchid.CareInfo);
                orchid.GetCareInfo(orchid.CareInfo);
            }

            binaryOut.Close();
        }
    }
}

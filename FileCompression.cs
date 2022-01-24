using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompression
{
    class FileCompression
    {
        private const string GZ_EXT = ".GZ";
        public int ExtractFromZipFile(string vstrZipFile,
                                      List<string> vlstFileToExtract = null)
        {
            string strUnZipPath = "";
            bool bolExtractFile = false;
            bool bolFindInList = false;
            int intExtractFiles = 0;
            try
            {
                if (System.IO.File.Exists(vstrZipFile))
                {
                    strUnZipPath = System.IO.Path.GetDirectoryName(vstrZipFile) + @"\";
                    bolFindInList = vlstFileToExtract != null && vlstFileToExtract.Count > 0;

                    using (System.IO.Compression.ZipArchive objZipArchive = System.IO.Compression.ZipFile.OpenRead(vstrZipFile))
                    {
                        foreach (System.IO.Compression.ZipArchiveEntry objZipArchiveEntry in objZipArchive.Entries)
                        {
                            if (bolFindInList)
                            {
                                if (vlstFileToExtract.Contains(objZipArchiveEntry.FullName, StringComparer.OrdinalIgnoreCase))
                                {
                                    bolExtractFile = true;
                                }
                                else
                                {
                                    bolExtractFile = false;
                                }
                            }
                            else
                            {
                                bolExtractFile = true;
                            }

                            if (bolExtractFile)
                            {
                                // Si c'est un répertoire, on le cré.
                                if (objZipArchiveEntry.Name.Length == 0 &&
                                   (objZipArchiveEntry.FullName.EndsWith(System.IO.Path.PathSeparator.ToString(), StringComparison.OrdinalIgnoreCase) ||
                                   objZipArchiveEntry.FullName.EndsWith(System.IO.Path.AltDirectorySeparatorChar.ToString(), StringComparison.OrdinalIgnoreCase)))
                                {
                                    System.IO.Directory.CreateDirectory(strUnZipPath + objZipArchiveEntry.FullName);
                                }
                                else
                                {
                                    using (System.IO.FileStream objUnZipFileStream = new System.IO.FileStream(strUnZipPath + objZipArchiveEntry.FullName, System.IO.FileMode.Create))
                                    {
                                        objZipArchiveEntry.Open().CopyTo(objUnZipFileStream);
                                        objUnZipFileStream.Flush();
                                        objUnZipFileStream.Close();
                                        objUnZipFileStream.Dispose();

                                        intExtractFiles += 1;
                                    }

                                }
                            }
                        }
                        objZipArchive.Dispose();
                    }
                }
            }
            catch (System.Exception e)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(e).Throw();
            }

            return intExtractFiles;
        }

        public string GZipFile(string vstrFileToGZip)
        {
            string strGZipedFile = "";

            try
            {
                if (System.IO.File.Exists(vstrFileToGZip))
                {
                    strGZipedFile = System.IO.Path.GetDirectoryName(vstrFileToGZip) + @"\";
                    strGZipedFile += System.IO.Path.GetFileName(vstrFileToGZip) + GZ_EXT;

                    using (System.IO.FileStream objFileToZip = System.IO.File.Open(vstrFileToGZip, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        using (System.IO.FileStream objGzipFile = System.IO.File.Create(strGZipedFile))
                        {
                            using (System.IO.Compression.GZipStream objGZipStream = new System.IO.Compression.GZipStream(objGzipFile, System.IO.Compression.CompressionMode.Compress))
                            {
                                objFileToZip.CopyTo(objGZipStream);

                                objGZipStream.Flush();
                                objGZipStream.Close();
                                objGZipStream.Dispose();
                            }
                        }

                        objFileToZip.Flush();
                        objFileToZip.Close();
                        objFileToZip.Dispose();
                    }
                }
            }
            catch (System.Exception e)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(e).Throw();
            }

            return strGZipedFile;
        }

        public string UnGZipFile(string vstrFileToUnGZip)
        {
            string strUnGZipFile = "";
            try
            {
                if (System.IO.File.Exists(vstrFileToUnGZip) && vstrFileToUnGZip.EndsWith(GZ_EXT, StringComparison.OrdinalIgnoreCase))
                {
                    strUnGZipFile = vstrFileToUnGZip.Substring(0, vstrFileToUnGZip.Length - GZ_EXT.Length);

                    using (System.IO.FileStream objFileToZip = System.IO.File.Open(vstrFileToUnGZip, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        using (System.IO.FileStream objGzipFile = System.IO.File.Create(strUnGZipFile))
                        {
                            using (System.IO.Compression.GZipStream objGZipStream = new System.IO.Compression.GZipStream(objFileToZip, System.IO.Compression.CompressionMode.Decompress))
                            {
                                objGZipStream.CopyTo(objGzipFile);

                                objGZipStream.Flush();
                                objGZipStream.Close();
                                objGZipStream.Dispose();
                            }

                            objGzipFile.Flush();
                            objGzipFile.Close();
                            objGzipFile.Dispose();
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(e).Throw();
            }

            return strUnGZipFile;
        }

    }
}

using System;

namespace ManagerFile.Fomatter
{
    public static class FormatterFactory
    {
        public static IFileSystemFormatter CreateInstance(string formatterName = null)
        {
            formatterName = formatterName ?? "Default";

            var type = Type.GetType($"ManagerFile.Fomatter.{formatterName}FileSystemFormatter");

            return Activator.CreateInstance(type) as IFileSystemFormatter;
        }
    }
}

﻿using ManagerFile.Models;
using System.Collections.Generic;
using System.Linq;
using Humanizer;

namespace ManagerFile.Fomatter
{
    public sealed class HumanizerFileSystemFormatter : IFileSystemFormatter
    {
        public object ToJson(IEnumerable<FileSystemObject> objs)
        {
            return objs?.Select(obj => new
            {
                obj.Name,
                Id = obj.Id.Replace(@"\", @"\\"),
                obj.IsFile,
                obj.HasChilds,
                LastWriteTime = obj.LastWriteTime.Humanize(),
                CreationTime = obj.CreationTime.Humanize(),
                Size = obj.Size.HasValue ? obj.Size.Value.Bytes().Humanize() : null,
                obj.Extension
            });
        }
    }
}

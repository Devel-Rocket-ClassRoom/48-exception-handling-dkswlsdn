using System;
using System.Collections.Generic;
using System.Text;

public class FilePathValidator
{
    private string[] _strings = { "<", ">", "|", "\"", "*", "?" };

    public void ValidatePath(string path)
    {
        if (path == null || path.Equals(string.Empty))
        {
            throw new ArgumentNullException("[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.", new ArgumentNullException());
        }
        foreach (var s in _strings)
        {
            if (path.Contains(s))
            {
                throw new ArgumentException($"[Argument 오류] 경로에 금지 문자\'{s}\'가 포함되어있습니다");
            }
        }
            if (path.Length > 260)
        {
            throw new ArgumentOutOfRangeException("[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다", new ArgumentOutOfRangeException());
        }

        Console.WriteLine($"경로가 유효합니다: {path}");
    }

    public void ValidateExtension(string path, string[] allowedExtensions)
    {
        if (!path.Contains("."))
        {
            throw new ArgumentException();
        }

        string ext = path.Split('.')[1];

        foreach (string extension in allowedExtensions)
        {
            if (path.Contains($".{extension}"))
            {
                Console.WriteLine($"확장자가 유효합니다: .{extension}");
                return;
            }
        }

        throw new ArgumentException($"허용되지 않은 확장자입니다: .{ext}");
    }
}
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;

if (args.Length > 0 && !string.IsNullOrWhiteSpace(args[0]))
{
    string pattern = @"^ide://open/?\?(?:url=file://|file=)(.+?)(?:&line=(\d+))?$";
    Match m = Regex.Match(args[0], pattern);
    if (m.Success)
    {
        string file = HttpUtility.UrlDecode(m.Groups[1].Value);
        file = file.Replace("/", "\\");

        Console.Write("File: ");
        Console.WriteLine(file);

        // -r Force to open a file or folder in an already opened window.
        string arguments = "-r \"%file%\"";

        if (!string.IsNullOrEmpty(m.Groups[2].Value))
        {
            Console.Write("Line: ");
            Console.WriteLine(m.Groups[2].Value);

            // -g Open a file at the path on the specified line and character position.
            arguments = "-r -g \"%file%:%line%\"";
        }

        arguments = arguments.Replace("%file%", file);
        if (arguments.Contains("%line%"))
            arguments = arguments.Replace("%line%", m.Groups[2].Value);

        Console.WriteLine("Strating \"VS Code\"...");

        Process.Start(new ProcessStartInfo
        {
            FileName = "code.exe",
            Arguments = arguments,
            UseShellExecute = true
        });
    }
}

using System;

string[] allowedExtension = { "txt", "csv" };
FilePathValidator validator = new FilePathValidator();

Console.WriteLine("=== 경로 검증 테스트 ===");

TryValidatePath("C:/Users/data/report.txt");
TryValidatePath("");
TryValidatePath("C:/Users/da<ta/report.txt");
TryValidatePath("C:/Useawauhfilauroiauwbrgoiuaroiguhaesiorughosieurgoisuebroiusebdroigubsaeruigpiauesrhfgiuaserhguihousevouhsuierhoiuageriugaiuwrgoiaubewrgiuaesbviueeriouhseprioughpseiourghsiuerhgoisuehroguisheoirughsoieurghaoiuwbrgoiuabeoiubgseorhsoeiurfhgsiuerhgoiusergiousherguihseriughsleirughsleirugrs/data/report.txt");


Console.WriteLine("\n=== 확장자 검증 테스트 ===");

TryValidateExtension("C:/Users/data/report.txt");
TryValidateExtension("C:/Users/data/report.csv");
TryValidateExtension("C:/Users/data/report.exe");




void TryValidatePath(string path)
{
    try
    {
        validator.ValidatePath(path);
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void TryValidateExtension(string path)
{
    try
    {
        validator.ValidateExtension(path, allowedExtension);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
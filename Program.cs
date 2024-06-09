
var input = "hello";
var output = "";

var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);

using (var md5 = System.Security.Cryptography.MD5.Create())
{
    var hashBytes = md5.ComputeHash(inputBytes);
    output = Convert.ToHexString(hashBytes);
}

Console.WriteLine($"MD5 hash is {output}");

var hash = MD5.MD5.Calculate(inputBytes);

Console.WriteLine($"MD5 hash is {output}");
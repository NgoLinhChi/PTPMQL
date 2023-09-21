using System.Threading.Tasks.Dataflow;
using NewApp.Models;
GPT PTBacNhat = new GPT();
GPT PTBacHai = new GPT();
string ketqua = PTBacNhat.PTBacNhat(1,2);
System.Console.WriteLine(ketqua);
ketqua = PTBacHai.PTBacHai(1,6,9);
System.Console.WriteLine(ketqua);
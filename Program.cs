using System.Collections;
using NewApp.Models;
internal class program{
ArrayList stdList = new ArrayList();
for (int i = 0; i<2; i++)
{
    Student std = new Student();
    std.NhapThongTin();
    stdList.Add(std);
}
foreach(Student std in stdList)
{
  std.HienThiThongTin();
}
}
//Le Quynh Anh_2021050074
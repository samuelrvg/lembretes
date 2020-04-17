
//Formatos de datas

CultureInfo culture = new CultureInfo("pt-BR");
public string FormatDate { get; set; }

FormatDate.ToString("dd/MM/yyyy"); // 16/04/2020
FormatDate.ToString("MMMM/dd", culture) // abril/16
FormatDate.ToString("MMM HH:mm", culture) // abr 02:04:22
FormatDate.ToString("MMMM", CultureInfo.InvariantCulture) // April - define uma cultura default em inglês
FormatDate.ToString(culture) // 17/04/2020 02:01:19
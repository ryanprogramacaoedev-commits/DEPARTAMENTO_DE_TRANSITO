Console.Clear();

int ano, nasc, status;

Console.WriteLine("--------------------------");
Console.WriteLine(" DEPARTAMENTO DE TRANSITO ");
Console.WriteLine("--------------------------");
Console.Write("Ano atual (YYYY): ");
ano = Convert.ToInt32(Console.ReadLine());
Console.Write("Ano de Nascimento (YYYY): ");
nasc = Convert.ToInt32(Console.ReadLine());

status = ( ano - nasc );

if (status>=18)
{
 Console.WriteLine("-------- STATUS --------");   
 Console.WriteLine($" IDADE: {status} ANOS");   
 Console.WriteLine("APTO A TIRAR A CARTEIRA");   
 Console.WriteLine("------------------------");   
}
else
{
 Console.WriteLine("-------------- STATUS --------------");   
 Console.WriteLine($" IDADE: {status} ANOS");   
 Console.WriteLine("NÃO ETSA APTO A TIRAR A CARTEIRA");   
 Console.WriteLine("------------------------------------");   
}
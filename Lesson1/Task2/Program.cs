int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
Console.WriteLine(sum);

long l1 = 6;
long sum2 = l1 + i1;
Console.WriteLine(sum2);

double d1 = 5.5;
double sum3 = d1 + i1;

int product1 = i1 * i2;
long product2 = l1 * i1;
double product3 = i1 * d1;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);

int quotient = i1 / i2;
Console.WriteLine(quotient);

d1 = 6;
double quotient2 = i1 / d1;
Console.WriteLine(quotient2);

// Домашнее задание. Вычислить значение формулы a * b
//                                              _____
//
//                                              c + d ,
// где a,b,c,d - некоторые целые цисла.
// Результат вывести на экран.


int a = 4;
int b = 3;
int c = 2;
int d = 1;
int product4 = a * b;
int sum4 = c + d;
double quotient3 = product4 / sum4;
Console.WriteLine(quotient3);
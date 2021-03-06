int value = 0;
value = value + 5;//o mesmo que usar o "value += 5".
Console.WriteLine(value);

value += 2;//quando o + é usado antes do = é a mesma coisa que "value = value + 2".
Console.WriteLine(value);

value =+ 2;//quando o + é usado após o = o valor de 2 será atribuido a variável "value".
Console.WriteLine(value);
value += 2;//como a variável "value" passou a ser atribuída ao valor "2" essa soma trará o valor 4 como resultado.
Console.WriteLine(value);
//----------------------------------
int valuee = 0;
valuee = valuee + 1;//o valor de "valuee" de 0 passou a ser 1.
valuee++;//incremento de uma unidade fazendo o valor se tornar 2.
Console.WriteLine("\n"+valuee);// \n usado para quebra de linha e separar de operações anteriores.
valuee++;//incremento de uma unidade fazendo o valor se tornar 3.
Console.WriteLine(valuee);
valuee--;//decremento de uma unidade fazendo o valor se tornar 2 novamente.
Console.WriteLine(valuee);

//Entendendo melhor incremento e decremento.
int valor = 1;
 valor = valor + 1;
 Console.WriteLine("Primeiro incremento: " + valor);

 valor +=1;
 Console.WriteLine("Segundo incremento: " + valor);

 valor++;
 Console.WriteLine("Terceiro incremento: " + valor);

 valor = valor - 1;
 Console.WriteLine("Primeiro decremento: " + valor);

 valor -= 1;
 Console.WriteLine("Segundo decremento: " + valor);

 valor--;
 Console.WriteLine("Terceiro decremento: " + valor);

//Incremento e Decremento antes e depois da variável:
int valorr = 1;
valorr++;
Console.WriteLine("Primeiro: " + valorr);//2 o valor foi incremente antes de invocarmos a variável, sendo assim ela já imprime incrementada.
Console.WriteLine("Segundo: " + valorr++);//2 o valor é repetido pois ela é incrementada no final, ou seja, só será alterado após essa linha de código.
Console.WriteLine("Terceiro: " + valorr);//3 ao chamar a variável novamente ela já vem com o incremento da linha anterior.
Console.WriteLine("Quarto: " + (++valorr));// 4 como o incremento vem na frente da variável ela já é incrementada e exibida na mesma linha de código.

//Referente a linha do quarto valor: Embora não seja estritamente necessário, adicionamos parênteses em torno da expressão (++value) para melhorar a legibilidade. Ver tantos operadores + próximos uns dos outros faz com que pareça que o código poderia ser mal compreendido por outros desenvolvedores.

//Desafio
/*Neste desafio, você escreverá um código que usará uma fórmula para converter uma temperatura de graus Fahrenheit para Celsius. Você imprimirá o resultado em uma mensagem formatada para o usuário.
int fahrenheit = 94;
Para converter temperaturas de graus Fahrenheit para Celsius, primeiro subtraia 32 e, em seguida, multiplique por cinco nonos (5/9).
Por fim, você combinará as variáveis com cadeias de caracteres literais passadas para uma série de comandos Console.WriteLine() para formar a mensagem completa.

Quando você tiver terminado, a mensagem deverá ser semelhante à seguinte saída:
Saída: The temperature is 34.444444444444444444444444447 Celsius.
*/
int fahrenheit = 94;
fahrenheit -= 32;
decimal Celsius = (decimal)fahrenheit * (5m /9m);
Console.WriteLine($"The temperature is {Math.Round(Celsius,2)} Celsius");//Math.Round usado para diminuir casas decimais.

/*Solução possível:
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");
*/

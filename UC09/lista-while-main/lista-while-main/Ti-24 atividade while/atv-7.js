let a = 0, b = 1, temp;
let contador = 0;
while (contador < 10) {
    console.log(a);
    temp = a + b;
    a = b;
    b = temp;
    contador++;
}
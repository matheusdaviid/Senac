let num9 = 1234; // Você pode alterar este valor
let somaDigitos = 0;
while (num9 > 0) {
    somaDigitos += num9 % 10;
    num9 = Math.floor(num9 / 10);
}
console.log(somaDigitos);
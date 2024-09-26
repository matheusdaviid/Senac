const palavra = "programação"; // adicione a palavra para conta as vogais
const vogais = palavra.match(/[aeiou]/gi);
console.log("Quantidade de vogais:", vogais ? vogais.length : 0); 

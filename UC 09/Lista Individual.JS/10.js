const palavras = ["maçã", "banana", "laranja"]; // Adicione as palavras que quer
const maiorPalavra = palavras.reduce((a, b) => a.length > b.length ? a : b);
console.log("Palavra com maior número de caracteres:", maiorPalavra); 

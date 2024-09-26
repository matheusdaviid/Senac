function ordemAlfabética(array) {
    return array.join("").split("").sort().join("");
}

const strings = ["banana", "maçã", "laranja"];
console.log(ordemAlfabética(strings)); // Resultado: "aaablnmnrr"

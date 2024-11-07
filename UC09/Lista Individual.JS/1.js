function mediaNúmeros(array) {
    let soma = 0;
    for (let i = 0; i < array.length; i++) {
        soma += array[i];
    }
    return soma / array.length;
}
console.log(mediaNúmeros([10, 20, 30, 40]));

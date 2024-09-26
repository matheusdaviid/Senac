let num8 = 2;
while (num8 <= 50) {
    let primo = true;
    let divisor = 2;
    while (divisor < num8) {
        if (num8 % divisor === 0) {
            primo = false;
            break;
        }
        divisor++;
    }
    if (primo) {
        console.log(num8);
    }
    num8++;
}
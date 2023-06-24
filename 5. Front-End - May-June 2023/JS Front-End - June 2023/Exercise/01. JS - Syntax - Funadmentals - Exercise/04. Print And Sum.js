function printAndSum (start, end) {
    const numbers = [];
    let sum = 0;

    for (let i = start; i <= end; i++) {
        numbers.push(i);
        sum += i;
    }

    console.log(numbers.join(" "));
    console.log(`Sum: ${sum}`);
}

printAndSum(5,10);
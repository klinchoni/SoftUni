function listOfNames (arr) {
    arr.sort((a, b) => a.localeCompare(b));

    let i = 1;
    for (const name of arr) {
        console.log(`${i}.${name}`);
        i++;
    }
}

listOfNames(["John", "Bob", "Christina", "Ema"]);
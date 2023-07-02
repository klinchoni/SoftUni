function wordsUppercase (text) {
    const result = text
    .toUpperCase()
    .split(/[\W]+/)
    .filter((w) => w.length >= 1)
    .join(", ");

    console.log(result);
}

wordsUppercase("Hi, how are you?");
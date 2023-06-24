function censorWords (text, word) {
    const censorshipWord = "*".repeat(word.length);

    while(text.includes(word)) {
        text = text.replace(word, censorshipWord);
    }

    console.log(text);
}

censorWords('Find the hidden word', 'hidden');
function editElement(reference, match, replacer) {
    const inputRef = document.querySelector("#e1");
    const input= reference.textContent;
    reference.textContent = input.replace(new RegExp(match, 'g'), replacer);
}
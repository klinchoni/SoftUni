function solve() {
  const input = document.querySelector("#input").value.split(".");
  // clear empty last element
  input.pop();
  const container = document.querySelector("#output");

  while (input.length > 0) {
    const p = document.createElement("p");
    p.textContent = input
      .splice(0, 3)
      .map((text) => text.trim())
      .join(".");
    container.appendChild(createParagraph());
  }
}

// JUDGE 100/100

function solve() {
  const textArea = document.getElementById('input');
  let output = document.getElementById('output');
  let sentences = textArea.value.split('.');
  sentences.pop();
  console.log(sentences);

  while (sentences.length > 0) {
    let paragraph = document.createElement('p');
    let curentText = sentences.splice(0,3).map((x) => x.trimStart());
    paragraph.textContent = curentText.join('.') + '.';
    output.appendChild(paragraph);
  }
}
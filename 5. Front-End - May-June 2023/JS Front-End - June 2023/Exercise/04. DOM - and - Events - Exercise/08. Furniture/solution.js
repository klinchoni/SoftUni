function solve() {
  const formatButton = document.querySelector("#exercise button");
  formatButton.addEventListener("click", parseFurnitureInput);

  const buyButton = document.querySelector("#exercise button:nth-of-type(2)");
  buyButton.addEventListener("click", buySelectedFurniture);

  Array.from(document.querySelectorAll('input[type="checkbox"]')).forEach(
    (checkbox) => checkbox.removeAttribute("disabled")
  );
}

function buySelectedFurniture() {
  const checkboxes = Array.from(
    document.querySelectorAll('input[type="checkbox"]:checked')
  );
  // Hardest thing in the whole task
  const cart = checkboxes.map(mapCheckboxToObject).reduce(
    (acc, curr) => {
      acc.names.push(curr.name);
      acc.price += curr.price;
      acc.averageDecorationFactor += curr.decFactor / checkboxes.length;

      return acc;
    },
    {
      names: [],
      price: 0,
      averageDecorationFactor: 0,
    }
  );

  const cartTextArea = document.querySelector(
    "#exercise textarea:nth-of-type(2)"
  );
  cartTextArea.value = `
    Bought furniture: ${cart.names.join(", ")}
    Total price: ${cart.price.toFixed(2)}
    Avg Dec Factor: ${cart.averageDecorationFactor.toFixed(2)}
  `;
}

function mapCheckboxToObject(checkbox) {
  const row = checkbox.parentElement.parentElement;
  const name = row.querySelector("td:nth-of-type(2)").innerText;
  const price = Number(row.querySelector("td:nth-of-type(3)").innerText);
  const decFactor = Number(row.querySelector("td:nth-of-type(4)").innerText);

  return { name, price, decFactor };
}

function parseFurnitureInput() {
  const input = JSON.parse(document.querySelector("#exercise textarea").value);
  const tableBody = document.querySelector("tbody");
  // TODO: naming
  const cellCreator = createCellCreator();

  input
    .map(cellCreator.createFurnitureRow)
    .forEach((row) => tableBody.appendChild(row));
}

function createCellCreator() {
  function createImageCell(src) {
    const imageCell = document.createElement("td");
    const image = document.createElement("img");
    image.src = src;
    imageCell.appendChild(image);

    return imageCell;
  }

  function createTextCell(text) {
    const cell = document.createElement("td");
    cell.textContent = text;

    return cell;
  }

  function createCheckboxCell() {
    const checkCell = document.createElement("td");
    const checkbox = document.createElement("input");
    checkbox.type = "checkbox";
    checkCell.appendChild(checkbox);

    return checkCell;
  }

  return {
    createFurnitureRow(furniture) {
      const row = document.createElement("tr");

      row.appendChild(createImageCell(furniture.img));
      row.appendChild(createTextCell(furniture.name));
      row.appendChild(createTextCell(furniture.price));
      row.appendChild(createTextCell(furniture.decFactor));
      row.appendChild(createCheckboxCell());

      return row;
    },
  };
}

// JUDGE 100/100 

function solve() {
  const generateButtonElement = document.querySelector("#exercise button");
  generateButtonElement.addEventListener("click", createFurniture);
  const buyButton = document.querySelectorAll("button")[1];
  buyButton.addEventListener("click", buy);
  console.log(buyButton);

  function createFurniture() {
    const textAreaElement = document.querySelector("#exercise textarea");
    const tableBodyElement = document.querySelector("tbody");
    const values = JSON.parse(textAreaElement.value);

    for (const {img, name, price, decFactor} of values) {
      const tableRow = createHtmlElement('tr', '', tableBodyElement);
      const tdImgElement = createHtmlElement('td', '', tableRow);
      createHtmlElement('img','',tdImgElement, '', {src : img}); 
      const tdFurnitureName = createHtmlElement('td', '', tableRow);
      createHtmlElement('p',name, tdFurnitureName);
      const tdFurniturePrice = createHtmlElement('td','', tableRow);
      createHtmlElement('p', price, tdFurniturePrice);
      const tdFurnitureDeFactor = createHtmlElement('td', '', tableRow);
      createHtmlElement('p', decFactor, tdFurnitureDeFactor);
      const tdInput = createHtmlElement('td','', tableRow);
      createHtmlElement('input','', tdInput, '', {type :'checkbox'});
    }
  }

  function createHtmlElement(typeOfElement,  content,   parent,  classes, attributes) {
    const htmlElement = document.createElement(typeOfElement);

    if (typeOfElement !== "input" && content) {
      htmlElement.textContent = content;
    }
    if(typeOfElement==='input' && content){
      htmlElement.value = content;
    }
    if(classes){
      htmlElement.classList.add(...classes);
    }
    if (attributes) {
      for (const key in attributes) {
        htmlElement.setAttribute(key, attributes[key]);
      }
    }
    if(parent){
      parent.appendChild(htmlElement);
    }
    return htmlElement;
  }

  function buy() {
    let boughtFurnitureNames = [];
    let totalPrice = 0;
    let averageDeFactor = 0;

    Array.from(document.querySelectorAll("tbody tr")).forEach((row) => {
      checkbox = row.querySelector("td:nth-child(5) input");
      if (checkbox.checked) {
        const furnitureName =
          row.querySelector("td:nth-child(2) p").textContent;
        const price = row.querySelector("td:nth-child(3) p").textContent;
        const deFactor = row.querySelector("td:nth-child(4) p").textContent;
        boughtFurnitureNames.push(furnitureName);
        totalPrice += Number(price);
        averageDeFactor += Number(deFactor);
      }
    });
    averageDeFactor /= boughtFurnitureNames.length;
    const textAreaOutput = document.querySelectorAll("textarea")[1];
    textAreaOutput.textContent = `Bought furniture: ${boughtFurnitureNames.join(
      ", "
    )}\nTotal price: ${totalPrice.toFixed(
      2
    )}\nAverage decoration factor: ${averageDeFactor}`;
  }
}
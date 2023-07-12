function addItem() {
    const value = document.querySelector("#newItemText").value;

    const item = document.createElement("li");
    item.textContent = value;

    const deleteButton = document.createElement("a");
    deleteButton.href = "#";
    deleteButton.textContent = "[Delete]";
    deleteButton.addEventListener("click", (e) => {
        e.target.parentElement.remove();
    });

    item.appendChild(deleteButton);

    document.querySelector("ul").appendChild(item);
}

// SAME CODE BUT WITH SEPARATED FUNCTIONS

function addItem() {
    const value = document.querySelector("#newItemText").value;
    const listItem = createListItem(value);

    document.querySelector("ul").appendChild(item);
}

function createListItem(text) {
    const item = document.createElement("li");
    item.textContent = text;
    item.appendChild(createDeleteButton());

    return item;
}

function createDeleteButton() {
    const deleteButton = document.createElement("a");
    deleteButton.href = "#";
    deleteButton.textContent = "[Delete]";
    deleteButton.addEventListener("click", (e) => {
        e.target.parentElement.remove();
    });

    return deleteButton;
}

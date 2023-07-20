function create(words) {
   const container = document.querySelector("#content");

   function onClick(e) {
     const invisibleParagraph = e.currentTarget.querySelector("p");
     invisibleParagraph.style.display = "block";
   }
 
   function createDiv(word) {
     const div = document.createElement("div");
     const p = document.createElement("p");
     p.textContent = word;
     p.style.display = "none";
 
     div.appendChild(p);
     div.addEventListener("click", onClick);
 
     return div;
   }
 
   words.forEach((word) => {
     container.appendChild(createDiv(word));
   });
}

// JUDGE 100/100

function create(words) {
  let content = document.getElementById('content');
  
  words.forEach(word => {
     let createDiv = document.createElement('div');
     let paragraph = document.createElement('p');
     paragraph.textContent = word;
     paragraph.style.display = 'none';
     createDiv.addEventListener('click', () =>{
        paragraph.style.display = 'block';
     });

     createDiv.appendChild(paragraph);
     content.appendChild(createDiv);
  });
}
// FIRST WAY:
 function loadCommits() {
    const username = document.querySelector("#username").value;
    const repo = document.querySelector("#repo").value;
   
    if(!username || !repo) {
        //T TODO: print out error message
        return;
    }

    const list = document.querySelector("ul");
    list.innerHTML = "";

    fetch(`https://api.github.com/repos/${username}/${repo}/commits`)
    .then((res) => res.join())
    .then((commits) => {
        commits.forEach(({ commit }) => {
            const item = document.createElement("li");
            item.textContent = commit.message;

            list.appendChild(item);
        });
    });
}

// SECOND WAY:

async function loadCommits() {
    const username = document.querySelector("#username").value;
    const repo = document.querySelector("#repo").value;
   
    if(!username || !repo) {
        //T TODO: print out error message
        return;
    }

    const list = document.querySelector("ul");
    list.innerHTML = "";

    const response = await (
        await fetch(`https://api.github.com/repos/${username}/${repo}/commits`)
    ).json();

    response.forEach(({ commit }) => {
            const item = document.createElement("li");
            item.textContent = commit.message;

            list.appendChild(item);
        });
}

//THIRD WAY:

async function loadCommits() {
    const username = document.querySelector("#username").value;
    const repo = document.querySelector("#repo").value;
    const list = document.querySelector("#commits");
    try {
      const response = await fetch(
        `https://api.github.com/repos/${username}/${repo}/commits`
      );
      if (response.ok === false) {
        throw new Error(`${response.status} ${response.statusText}`);
      }
      const data = await response.json();
      list.innerHTML = "";
  
      data.forEach(({ commit }) => {
        list.innerHTML += `<li>
        ${commit.author.name}: ${commit.message}
            </li>`;
      });
    } catch (e) {
      list.innerHTML = `Error: ${e.message} (Not Found)`;
    }
}
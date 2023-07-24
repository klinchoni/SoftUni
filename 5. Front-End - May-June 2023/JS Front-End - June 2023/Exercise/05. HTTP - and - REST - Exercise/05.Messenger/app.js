function attachEvents() {
    const BASE_MESSAGE_URL = "http://localhost:3030/jsonstore/messenger";
    const sendButton = document
      .querySelector("#submit")
      .addEventListener("click", sendMessage);
    const refreshButton = document
      .querySelector("#refresh")
      .addEventListener("click", refreshMessages);
  
    const textAreaMessage = document.querySelector("#messages");
    const name = document.querySelector(
      "#controls > div:nth-child(1) > input[type=text]"
    );
    const message = document.querySelector(
      "#controls > div:nth-child(2) > input[type=text]"
    );
  
    function sendMessage() {
      const httpHeaders = {
        method: "POST",
        body: JSON.stringify({ author: name.value, content: message.value }),
      };
      name.value = "";
      message.value = "";
  
      fetch(BASE_MESSAGE_URL, httpHeaders)
        .then((response) => response.json())
        .catch((error) => {
          console.error(error);
        });
    }
  
    function refreshMessages() {
      fetch(BASE_MESSAGE_URL)
        .then((response) => response.json())
        .then((data) => {
          textAreaMessage.textContent = "";
          let newMessage = "";
          for (const key in data) {
            newMessage += `${data[key].author}: ${data[key].content}\n`;
          }
          textAreaMessage.textContent = newMessage.trim();
        })
        .catch((error) => {
          console.error(error.message);
        });
    }
  }
    attachEvents();

  // SECOND WAY:

  function attachEvents() {
    document.getElementById("refresh").addEventListener("click", refresh);
    document.getElementById("submit").addEventListener("click", send);
  
    async function refresh() {
      try {
        let res = await (
          await fetch("http://localhost:3030/jsonstore/messenger")
        ).json();
        document.getElementById("messages").innerHTML = "";
        let messages = Object.values(res)
          .map((v) => `${v.author}: ${v.content}`)
          .join("\n");
        document.getElementById("messages").value = messages;
      } catch (e) {}
    }
    async function send() {
      try {
        let author = document.querySelector('input[name="author"]').value;
        let message = document.querySelector('input[name="content"]').value;
        await fetch("http://localhost:3030/jsonstore/messenger", {
          method: "POST",
          body: JSON.stringify({ author: author, content: message }),
          headers: {
            "Content-type": "application/json; charset=UTF-8",
          },
        });
      } catch (e) {}
  
      document.querySelector('input[name="author"]').value = "";
      document.querySelector('input[name="content"]').value = "";
    }
  }
  
  attachEvents();

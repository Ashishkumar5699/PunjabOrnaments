//import axios from "axios";
let myHeaders;
const POSTMethod = (data: string, url: string) => {

    myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    //const raw = JSON.stringify({
    //  "username": "string",
    //  "password": "string"
    //});

    const requestOptions: object = {
      method: 'POST',
      headers: myHeaders,
      body: data,
      redirect: 'follow'
    };

    url = "https://localhost:5001/api/Account/login";
    fetch(url, requestOptions)
  .then(response => response.text())
  .then(result => console.log(result))
  .catch(error => console.log('error', error));

    // axios.get(url).then((response) => {
    //     console.log(response);
    //     console.log(response.data);
    //    // setPost(response.data);
    //   });
}

export {
    POSTMethod,
}
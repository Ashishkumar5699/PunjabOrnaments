//import axios from "axios";

const POSTMethod = (data: any, url : string) =>{

    var myHeaders = new Headers();
myHeaders.append("Content-Type", "application/json");

var raw = JSON.stringify({
  "username": "string",
  "password": "string"
});

var requestOptions:any = {
  method: 'POST',
  headers: myHeaders,
  body: raw,
  redirect: 'follow'
};

fetch("https://localhost:5001/api/Account/login", requestOptions)
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
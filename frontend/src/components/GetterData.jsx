import React, { useState } from "react";
import axios from "axios";

const GetterData = () => {
  const [data, setData] = useState([]);
  const handleClick = () => {
    try {
      axios
        .get("https://localhost:7222/api/DanePogodowe/PobierzWszystko", {
          headers: { "Content-Type": "application/json" },
        })
        .then((response) => {
          setData(response.data);
        });
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <div>
      <button onClick={handleClick}>Pobierz dane</button>
      <ul>
        {data.map((item) => (
          <li key={item.id}>
            <p>id: {item.id}</p> 
            <p>data: {item.dataPomiaru}</p> 
            <p>temp: {item.temperatura}</p> 
            <p>wigotność: {item.wilgotnoscWzgledna}</p>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default GetterData;

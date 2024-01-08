import "bootstrap/dist/css/bootstrap.css";
import Head from "next/head";
import { Inter } from "next/font/google";
import styles from "@/styles/Home.module.css";
import axios from "axios";
import { useEffect, useState } from "react";

const inter = Inter({ subsets: ["latin"] });

export default function Home() {
  const [cadastroViagem, setCadastroViagem] = useState([]);
  useEffect(() => {
    axios
      .get("https://localhost:7262/api/CadastroViagem")
      .then((response) => {
        setCadastroViagem(response.data);
      })
      .catch((error) => {
        console.error("Erro ao buscar lista de cadastros", error);
      });
  }, []);
  return (
    <>
      <Head>
        <title>Agência de Viagens</title>
        <meta
          name="description"
          content="Exenplo de uso de API C# em uma aplicação next"
        />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="icon" href="/img/logo.jpeg" />
      </Head>
      <main className={`${styles.main} ${inter.className}`}>
        <h1>Lista de cadastros</h1>
        <table class="table">
          <thead>
            <tr>
              <th scope="col">id</th>
              <th scope="col">cliente</th>
              <th scope="col">destino</th>
            </tr>
          </thead>
          {cadastroViagem.map((element) => (
            <tbody key={element.idCadastro}>
              <tr>
                <td>{element.idCadastro}</td>
                <td>{element.clientes}</td>
                <td>{element.destinos}</td>
              </tr>
            </tbody>
          ))}
        </table>
      </main>
    </>
  );
}

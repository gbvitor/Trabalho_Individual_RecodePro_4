import Image from "next/image";
import React from "react";

function destinos() {
  return (
    <>
      <h3 className="text-center m-5">Destinos</h3>
      <div className="container">
        <div className="row row-cols-1 row-cols-md-2 g-4">
          <div className="col">
            <div className="card">
              <Image
                src="/img/EUA.jpg"
                className="card-img-top"
                alt="..."
                width={200}
                height={200}
              />
              <div className="card-body">
                <h5 className="card-title">Estados Unidos</h5>
                <p className="card-text">
                  Os Estados Unidos é um país com muitas opções de lazer e
                  atividades para todos os gostos. É um destino que oferece
                  muitas opções de entretenimento e diversão. Alguns dos pontos
                  turísticos mais famosos são a Estátua da Liberdade, a Times
                  Square, os famosos musicais na Broadway em Nova York e os
                  parques de diversões de Orlando. Além disso, há muitas opções
                  de passeios em parques nacionais como o Grand Canyon e a
                  Golden Gate Bridge em São Francisco. A culinária americana é
                  uma das mais famosas do mundo e oferece pratos deliciosos como
                  o hambúrguer, o hot dog e o cheesecake. Com certeza uma viagem
                  para os Estados Unidos será uma experiência inesquecível!🇺🇸🌍
                </p>
              </div>
            </div>
          </div>
          <div className="col">
            <div className="card">
              <Image
                src="/img/FRA.jpg"
                className="card-img-top"
                alt="..."
                width={200}
                height={200}
              />
              <div className="card-body">
                <h5 className="card-title">França</h5>
                <p className="card-text">
                  A França é um país que encanta os turistas com sua cultura,
                  história e gastronomia. É um destino que oferece muitas opções
                  de lazer e entretenimento para todos os gostos. Alguns dos
                  pontos turísticos mais famosos são a Torre Eiffel, o Museu do
                  Louvre, o Arco do Triunfo e a Catedral de Notre-Dame. Além
                  disso, a França é conhecida por seus vinhos e queijos
                  deliciosos. Há muitas opções de passeios em vinícolas e
                  degustações de queijos em diversas regiões do país. A
                  culinária francesa é uma das mais famosas do mundo e oferece
                  pratos deliciosos como o croissant, o crepe e o ratatouille.
                  Com certeza uma viagem para a França será uma experiência
                  inesquecível!🇫🇷🌍
                </p>
              </div>
            </div>
          </div>
          <div className="col">
            <div className="card">
              <Image
                src="/img/JPN.jpg"
                className="card-img-top"
                alt="..."
                width={200}
                height={200}
              />
              <div className="card-body">
                <h5 className="card-title">Japão</h5>
                <p className="card-text">
                  O Japão é um país com uma cultura rica e diversa. É um destino
                  que oferece muitas opções de lazer e entretenimento para todos
                  os gostos. Alguns dos pontos turísticos mais famosos são o
                  Monte Fuji, o Templo de Kiyomizu em Kyoto, o Castelo de Himeji
                  e o Santuário de Itsukushima em Hiroshima. Além disso, o Japão
                  é conhecido por sua culinária deliciosa e única. Há muitas
                  opções de pratos típicos como o sushi, o ramen e o tempura. A
                  cultura japonesa é muito rica em tradições e costumes que
                  valem a pena conhecer. Com certeza uma viagem para o Japão
                  será uma experiência inesquecível!🇯🇵🌍
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

export default destinos;

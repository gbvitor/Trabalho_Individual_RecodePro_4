import React from "react";

function contatos() {
  return (
    <>
      <section className="container-fluid">
        <h3 className="m-5 text-center">Informações de Contato</h3>
        <dl className="row">
          <dt className="col-sm-3">Email:</dt>
          <dd className="col-sm-9">name@email.com</dd>

          <dt className="col-sm-3">Telefone:</dt>
          <dd className="col-sm-9">(xx)xxxxx-xxxx</dd>
        </dl>
        <h5>Nos contate:</h5>
        <div className="mb-3">
          <label for="exampleFormControlInput1" className="form-label">
            Email address
          </label>
          <input
            type="email"
            className="form-control"
            id="exampleFormControlInput1"
            placeholder="name@example.com"
          />
        </div>
        <div className="mb-3">
          <label for="exampleFormControlTextarea1" className="form-label">
            Example textarea
          </label>
          <textarea
            className="form-control"
            id="exampleFormControlTextarea1"
            rows="3"
          ></textarea>
        </div>
        <button type="submit" className="btn btn-primary">
          Submit
        </button>
      </section>
    </>
  );
}

export default contatos;

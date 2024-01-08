import "bootstrap/dist/css/bootstrap.css";

import Link from "next/link";

function Navbar() {
  return (
    <>
      <nav className="navbar navbar-expand-lg bg-body-tertiary">
        <div className="container-fluid">
          <button
            className="navbar-toggler"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarNavAltMarkup"
            aria-controls="navbarNavAltMarkup"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon"></span>
          </button>
          <div className="collapse navbar-collapse" id="navbarNavAltMarkup">
            <div className="navbar-nav">
              <Link className="nav-link" aria-current="page" href="/">
                Home
              </Link>
              <Link className="nav-link" href="/destinos">
                Destinos
              </Link>

              <Link className="nav-link" href="/promocoes">
                Promoções
              </Link>
              <Link className="nav-link" href="/contatos">
                Contatos
              </Link>
            </div>
          </div>
          <button className="btn btn-outline-success" type="submit">
            login
          </button>
        </div>
      </nav>
    </>
  );
}

export default Navbar;

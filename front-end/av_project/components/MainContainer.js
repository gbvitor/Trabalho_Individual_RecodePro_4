import Header from "./Header";
import Footer from "./Footer";

function Main({ children }) {
  return (
    <>
      <Header />
      <div>{children}</div>
      <Footer />
    </>
  );
}

export default Main;

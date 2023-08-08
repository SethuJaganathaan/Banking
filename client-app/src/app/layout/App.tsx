import { Outlet } from "react-router-dom";
import "./App.css";
import NavBar from "./NavBar";

function App() {
  return (
    <>
      <NavBar />
      <div style={{ marginTop: "7em" }}>
        <Outlet />
      </div>
    </>
  );
}

export default App;

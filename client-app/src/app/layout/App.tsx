import { Outlet, Route, Routes } from "react-router-dom";
import "./App.css";
import NavBar from "./NavBar";
import { Container } from "semantic-ui-react";

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

import { Menu } from "semantic-ui-react";

export default function NavBar() {
  return (
    <Menu fixed="top">
        <img
          src="/assets/dummy.png"
          alt="logo"
          style={{ marginRight: "6px", width: "80px", height: "auto" }}
        />
    </Menu>
  );
}

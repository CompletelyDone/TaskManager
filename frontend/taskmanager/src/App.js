import { useEffect } from "react";
import { Body } from "./components/Body";
import { Header } from "./components/Header";

function App() {
  useEffect(() => {
    document.title = 'Task Manager';
  }, []);

  return <div>
    <Header />
    <Body />
  </div>
}

export default App;

import { useEffect, useState } from "react";
import { Header } from "./components/Header";
import { MyProjects } from "./components/MyProjects";
import { Auth } from "./components/Auth";

function App() {
  const [isLogin, setIsLogin] = useState(false);

  useEffect(() => {
    document.title = "Task Manager";
  }, []);

  return (
    <div>
      <Header isLogin={isLogin} />
      {isLogin ? <MyProjects /> : <Auth />}
    </div>
  );
}

export default App;

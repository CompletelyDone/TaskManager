import { useEffect, useState } from "react";
import { Header } from "./components/Base/Header";
import { MyProjects } from "./components/Project/MyProjects";
import { Auth } from "./components/AuthReg/Auth";

function App() {
  const [isLogin, setIsLogin] = useState(true);

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

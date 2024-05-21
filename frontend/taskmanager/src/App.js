import { useEffect, useState } from "react";
import { Header } from "./components/Base/Header";
import { MyProjects } from "./components/Project/MyProjects";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { MainPage } from "./components/Base/MainPage";
import { NotFound } from "./components/Base/NotFound";
import { MyTasks } from "./components/TaskPage/MyTasks";

function App() {
  const [isLogin, setIsLogin] = useState(false);

  useEffect(() => {
    document.title = "Task Manager";
  }, []);

  return (
    <Router>
      <Header isLogin={isLogin} />
      <Routes>
        <Route path="/projects" element={<MyProjects />} />
        <Route path="/tasks" element={<MyTasks />} />
        <Route path="/" element={<MainPage />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
    </Router>
  );
}

export default App;

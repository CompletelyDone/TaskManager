import { SimpleGrid } from "@chakra-ui/react";
import { Project } from "./Project";

export const Body = () => {
  const temp = [
    {
      id: 1,
      title: "diplom",
      orderCompany: "vki",
      projectManager: "asd",
    },
    {
      id: 2,
      title: "Приёмка товара",
      orderCompany: "Zola",
      projectManager: "Валентина",
    },
    {
      id: 3,
      title: "Приготовление ужина",
      orderCompany: "Any",
      projectManager: "SomeOne",
    },
    {
      id: 3,
      title: "TaskManager",
      orderCompany: "Git",
      projectManager: "Роман",
    },
  ];

  return (
    <>
      <SimpleGrid
        spacing={6}
        templateColumns="repeat(auto-fill, minmax(200px, 1fr))"
      >
        {temp.map((project) => (
          <Project
            key={project.id}
            title={project.title}
            orderCompany={project.orderCompany}
            projectManager={project.projectManager}
          />
        ))}
      </SimpleGrid>
    </>
  );
};

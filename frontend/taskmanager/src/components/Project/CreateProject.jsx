import {
  Button,
  Card,
  Flex,
  Icon,
  Input,
  Modal,
  ModalBody,
  ModalContent,
  ModalFooter,
  ModalHeader,
  ModalOverlay,
  Select,
  useDisclosure,
} from "@chakra-ui/react";
import { IoMdAdd } from "react-icons/io";

export const CreateProject = () => {
  const { isOpen, onOpen, onClose } = useDisclosure();

  const tempCompanies = [
    {
        id: 1,
        title: "Xiaomi"
    },
    {
        id: 2,
        title: "Samsung"
    },
    {
        id: 3,
        title: "Apple"
    }
  ];
  const tempProjectManagers = [
    {
        id: 1,
        Name: "Роман",
        Surname: "Шитов",
        Email: "Roman.SonGoku.Army@gmail.com"
    },
    {
        id: 2,
        Name: "Валерий",
        Surname: "Михалёв",
        Email: "ValeryMikhalev@gmail.com"
    },
    {
        id: 3,
        Name: "Иван",
        Surname: "Арканов",
        Email: "ArkanovIvan@gmail.com"
    },
  ];

  return (
    <>
      <Card maxW="xs" align="center" variant="outline" onClick={onOpen}>
        <Flex justify="center" align="center" h="full">
          <Icon as={IoMdAdd} fontSize="5xl" />
        </Flex>
      </Card>

      <Modal isOpen={isOpen} onClose={onClose}>
        <ModalOverlay />
        <ModalContent>
          <ModalHeader>Добавить новый проект</ModalHeader>
          <ModalBody>
            <Input placeholder="Название проекта" />
            <Select>
                {tempCompanies.map((company) => (
                    <option value={company}>{company.title}</option>
                ))}
            </Select>
            <Select>
                {tempProjectManagers.map((manager) => (
                    <option key={manager.id} value={manager}>{manager.Surname} {manager.Name}</option>
                ))}
            </Select>
          </ModalBody>
          <ModalFooter>
            <Button>Добавить</Button>
            <Button onClick={onClose}>Close</Button>
          </ModalFooter>
        </ModalContent>
      </Modal>
    </>
  );
};

import {
  Box,
  Button,
  HStack,
  Input,
  Modal,
  ModalContent,
  ModalOverlay,
  Stack,
  Text,
} from "@chakra-ui/react";

export const Auth = ({ isOpen, onClose }) => {
  return (
    <Modal isOpen={isOpen} onClose={onClose}>
      <ModalOverlay />
      <div className="flex justify-center h-screen items-center">
        <ModalContent>
            <Text fontSize="25pt" align='center'>Авторизация</Text>
            <Stack spacing={3}>
              <Input placeholder="Введите email" />
              <Input placeholder="Введите пароль" />
            </Stack>
            <HStack mt={6}>
              <Button className="w-full">Войти</Button>
            </HStack>
        </ModalContent>
      </div>
    </Modal>
  );
};

import { Box, Button, HStack, Input, Stack, Text } from "@chakra-ui/react";

export const Auth = () => {
  return (
    <div className="flex justify-center h-screen items-center">
      <Box w="250px">
        <Text fontSize='25pt'>Авторизация</Text>
        <Stack spacing={3}>
          <Input placeholder="Введите email" />
          <Input placeholder="Введите пароль" />
        </Stack>
        <HStack mt={6}>
          <Button>Войти</Button>
          <Button>Зарегистрироваться</Button>
        </HStack>
      </Box>
    </div>
  );
};

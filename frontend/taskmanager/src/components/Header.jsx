import {
  Button,
  Menu,
  MenuButton,
  MenuDivider,
  MenuGroup,
  MenuItem,
  MenuList,
  Text,
} from "@chakra-ui/react";

export const Header = ({ isLogin }) => {
  return (
    <header className="flex w-full bg-teal-500 h-16 justify-between items-center">
      <div>
        <Button className="ml-6" variant="ghost">
          Главная
        </Button>
      </div>
      {isLogin ? (
        <Menu>
          <MenuButton className="mr-6">
            <Text fontSize="lg" as="b">
              Профиль
            </Text>
          </MenuButton>

          <MenuList>
            <MenuGroup title="Задачи">
              <MenuItem as="a" href="/">
                Мои проекты
              </MenuItem>
              <MenuItem as="a" href="/tasks/">
                Мои задачи
              </MenuItem>
            </MenuGroup>
            <MenuDivider />
            <MenuGroup title="Профиль">
              <MenuItem as="a" href="/">
                Редактировать профиль
              </MenuItem>
              <MenuItem as="a" href="/">
                Выйти
              </MenuItem>
            </MenuGroup>
          </MenuList>
        </Menu>
      ) : (
        <Button className="mr-6" variant="ghost">
          Авторизация
        </Button>
      )}
    </header>
  );
};

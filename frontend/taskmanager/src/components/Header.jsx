import {
  Menu,
  MenuButton,
  MenuDivider,
  MenuGroup,
  MenuItem,
  MenuList,
  Text,
} from "@chakra-ui/react";

export const Header = () => {
  return (
    <header className="flex w-full bg-teal-500 h-16 justify-between items-center">
      <div></div>
      <Menu>
        <MenuButton className="mr-6">
          <Text fontSize='lg' as='b'>Профиль</Text>
        </MenuButton>
        <MenuList>
          <MenuGroup title="Задачи">
            <MenuItem as="a" href="/">
              Мои проекты
            </MenuItem>
            <MenuItem as="a" href="/">
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
    </header>
  );
};

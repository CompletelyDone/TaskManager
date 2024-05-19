import {
  Box,
  Button,
  Card,
  CardBody,
  CardFooter,
  Divider,
  Heading,
  Text,
} from "@chakra-ui/react";

export const Project = ({ title, orderCompany, projectManager }) => {
  return (
    <Card maxW="xs" align='center' variant='outline'>
      <CardBody>
        <Heading size="md">{title}</Heading>
        <Divider className="mt-2"/>
        <Box>
          <Heading size="xs">
            Заказчик
          </Heading>
          <Text pt="2" fontSize="sm">
            {orderCompany}
          </Text>
          <Heading size="xs">
            Руководитель проекта
          </Heading>
          <Text pt="2" fontSize="sm">
            {projectManager}
          </Text>
        </Box>
      </CardBody>
      <CardFooter justify='center'>
        <Button variant="solid" colorScheme="teal">
          Перейти к задачам
        </Button>
      </CardFooter>
    </Card>
  );
};

import type { Route } from "./+types/home";
import HomePage from '~/pages/HomePage'

export function meta({}: Route.MetaArgs) {
  return [
    { title: "FinShark: Início" },
    { name: "description", content: "Bem-vindo à Finshark!" },
  ];
}

export default function Home() {
  return <HomePage />;
}
